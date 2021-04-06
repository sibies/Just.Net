using System.Linq;
using FluentAssertions;
using Just.Net;
using Just.Net.Models;
using Xunit;

namespace Just.Ne.Tests
{
    public class JustClientTests
    {
        [Fact]
        public void IsOnlineTest()
        {
            var client = new JustClient();
            var result = client.IsOnline();
            result.Should().BeTrue();
        }
        [Fact]
        public void CautareSedinteTest()
        {
            var client = new JustClient();
            var result = client.CautareSedinteAzi(Institutie.JudecatoriaSIBIU);
            result.Count().Should().BeGreaterThan(0);
        }

        [Fact]
        public void CautareDosareTest()
        {
            const string keyword = "sibies";
            var client = new JustClient();
            var result = client.CautareDosareByNumeParte(keyword);
            result.Count().Should().BeGreaterThan(0);
        }
    }
}
