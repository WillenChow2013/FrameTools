using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FrameDataToolWinform
{
    class Tools
    {
        public static string RemoveNonHexCharacters(string input)
        {
            Regex regex = new Regex("[^0-9A-Fa-f]");
            return regex.Replace(input, "");
        }

        public static string AddSpaceBetweenChars(string input)
        {
            return Regex.Replace(input, "..", "$0 ");
        }

        public static string CalculateHex8BitChecksum(string hexString)
        {
            int sum = 0;
            for (int i = 0; i < hexString.Length; i += 2)
            {
                sum += Convert.ToInt32(hexString.Substring(i, 2), 16);
            }
            byte checksum = (byte)(sum & 0xFF); // 取校验和的低8位
            return checksum.ToString("X2"); // 转换为两位16进制字符串
        }

        public static string CalculateHex16BitChecksum(string hexString)
        {
            int sum = 0;
            for (int i = 0; i < hexString.Length; i += 2)
            {
                sum += Convert.ToInt32(hexString.Substring(i, 2), 16);
            }
            int checksum = (sum & 0xFFFF); // 取校验和的低16位
            return checksum.ToString("X2"); // 转换为两位16进制字符串
        }

        public static string RemoveHexPrefix(string input)
        {
            return Regex.Replace(input, "(?i)0x", "");
        }

        public static string HexToCString(string hexString)
        {
            // 去除输入字符串中可能存在的空格与非法字符
            hexString = hexString.Replace(" ", "").Replace("\n", "").Replace("\r", "");

            int nHexChars = hexString.Length;
            StringBuilder sb = new StringBuilder();

            // 由于需要将每两个 HEX 字符转换为一个 C 语言数据格式的字节，
            // 因此需要从索引为0的位置开始，以步长为2遍历整个字符串
            for (int i = 0; i < nHexChars; i += 2)
            {
                // 取出当前两个 HEX 字符
                string hexValue = hexString.Substring(i, 2);

                // 将十六进制转换为十进制，并拼接为字符串
                sb.Append($"0x{hexValue},");
            }

            // 移除最后一个字节后面的逗号，并返回结果
            return sb.ToString().TrimEnd(',');
        }

        public static string StringToAsciiCode(string inputString)
        {
            StringBuilder sb = new StringBuilder();

            // 遍历字符串中的每个字符，将其转换为对应的 ASCII 码
            foreach (char c in inputString)
            {
                // 将 ASCII 码转换为字符串，并拼接到结果字符串中
                int val = c;
                sb.Append(val.ToString("X2"));
            }

            return sb.ToString();
        }

        public static string ConvertToAsciiString(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i += 2)
            {
                string hexValue = input.Substring(i, 2);
                int decimalValue = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
                char charValue = (char)decimalValue;
                sb.Append(charValue);
            }
            return sb.ToString();
        }

        public static ushort CalculateCrcCittFalse(string hexString)
        {
            // 将输入的HEX字符串转换为字节数组
            byte[] bytes = Enumerable.Range(0, hexString.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hexString.Substring(x, 2), 16))
                             .ToArray();

            // 计算CRC-CITT校验码
            ushort crc = 0xFFFF;
            for (int i = 0; i < bytes.Length; ++i)
            {
                crc ^= (ushort)(bytes[i] << 8);
                for (int j = 0; j < 8; ++j)
                {
                    if ((crc & 0x8000) != 0)
                    {
                        crc = (ushort)((crc << 1) ^ 0x1021);
                    }
                    else
                    {
                        crc <<= 1;
                    }
                }
            }

            return crc;
        }

        public static ushort GetCrc16Modbus(string hexString)
        {
            // 将HEX字符串转换成16进制数组
            byte[] hexArray = new byte[hexString.Length / 2];
            for (int i = 0; i < hexString.Length; i += 2)
                hexArray[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);

            // CRC16-MODBUS查表法实现
            ushort crc = 0xFFFF;
            for (int i = 0; i < hexArray.Length; i++)
            {
                crc ^= (ushort)hexArray[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x0001) != 0)
                        crc = (ushort)((crc >> 1) ^ 0xA001);
                    else
                        crc >>= 1;
                }
            }

            return crc;
        }

        public static byte GetCrc8(string hexString)
        {
            // 将HEX字符串转换成16进制数组
            byte[] hexArray = new byte[hexString.Length / 2];
            for (int i = 0; i < hexString.Length; i += 2)
                hexArray[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);

            // CRC8查表法实现
            const byte generator = 0x07;
            byte crc = 0;
            for (int i = 0; i < hexArray.Length; i++)
            {
                crc ^= hexArray[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x80) != 0)
                        crc = (byte)((crc << 1) ^ generator);
                    else
                        crc <<= 1;
                }
            }

            return crc;
        }




    }
}
