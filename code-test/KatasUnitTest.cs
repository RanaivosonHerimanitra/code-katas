using code_katas;
using System;
using System.Numerics;
using Xunit;

namespace code_test
{
    public class KatasUnitTest
    {

        [Fact]
        public void TestEncode()
        {
            var abc = "abcdefghijklmnopqrstuvwxyz";
            var key = "keyword";
            var cipher = new CipherKeyWord(abc, key);
            Assert.Equal("key", cipher.Encode("abc"));
            Assert.Equal("vxz", cipher.Encode("xyz"));
        }

        [Fact]
        public void TestDecode()
        {
            var abc = "abcdefghijklmnopqrstuvwxyz";
            var key = "keyword";
            var cipher = new CipherKeyWord(abc, key);
            Assert.Equal("abc", cipher.Decode("key"));
            Assert.Equal("xyz", cipher.Decode("vxz"));
        }

    }
}
