using System;
using Xunit;
using MyEncodingTools;

namespace MyEncodingToolsTests
{
    public class EncodingToolsTests
    {
        
        [Fact]
        public void RunLengthDecodeShouldConvertAnRLEStringToItsFullFormat()
        {
            Assert.Equal("", EncodingTools.RunLengthDecode(""));
            Assert.Equal("aaaaac", EncodingTools.RunLengthDecode("5a1c"));
            Assert.Equal("aaaaaccccccccc", EncodingTools.RunLengthDecode("5a9c"));
            Assert.Equal("ZZZnnnnn", EncodingTools.RunLengthDecode("3Z5n"));
        }

        [Fact]
        public void RunLengthDecodeShouldntAllowMultiDigitNumbers()
        {
            Assert.Equal("", EncodingTools.RunLengthDecode("5a10c"));
        }

        [Fact]
        public void RunLengthDecodeShouldReturnEmptyStringOnWrongFormat()
        {
            Assert.Equal("", EncodingTools.RunLengthDecode("a1c"));
            Assert.Equal("", EncodingTools.RunLengthDecode("5ac"));
        }

        [Fact]
        public void RunLengthDecodeShouldntAllowOtherCharacters()
        {
            Assert.Equal("", EncodingTools.RunLengthDecode("5*"));
        }

        [Fact]
        public void RunLengthEncoderShouldConvertAFullFormatToItsRLEString()
        {
            Assert.Equal("", EncodingTools.RunLengthEncode(""));
            Assert.Equal("5a1c", EncodingTools.RunLengthEncode("aaaaac"));
            Assert.Equal("5a9c", EncodingTools.RunLengthEncode("aaaaaccccccccc"));
            Assert.Equal("3Z5n", EncodingTools.RunLengthEncode("ZZZnnnnn"));
        }
    }
}
