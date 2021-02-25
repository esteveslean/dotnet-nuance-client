using FluentAssertions;
using System;
using Xunit;

namespace Dotnet.NuanceClient.UnitTests
{
    public class TranscriptorUrlTest
    {
        [Theory]      
        [InlineData("http://192.168.0.10:8008")]
        [InlineData("https://localhost:123")]
        [InlineData("https://transcritordns.com.br")]
        public void Should_Transcriptor_Url_Be_Valid(string transcriptorUrl)
        {
            ISupportsTranscriptorClient botClient = new Transcriber().DefineUrl(transcriptorUrl);

            botClient.TranscriptorUrl.Should().Contain("http");
        }

        [Theory]
        [InlineData("192.168.0.10:8008")]
        [InlineData("transcritordns.com")]
        public void Should_Throw_On_Invalid_Transcriptor_Url(string transcriptorUrl)
        {
            var exception = Assert.Throws<ArgumentException>(
                () => new Transcriber().DefineUrl(transcriptorUrl)
            );

            Assert.Equal("url", exception.ParamName);
        }

        [Fact]
        public void Should_Throw_On_Null_Transcriptor_Url()
        {
            var exception = Assert.Throws<ArgumentNullException>(
                () => new  Transcriber().DefineUrl(null)
            );
            Assert.Equal("url", exception.ParamName);
        }
    }
}
