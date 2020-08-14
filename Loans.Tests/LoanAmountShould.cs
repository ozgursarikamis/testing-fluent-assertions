using FluentAssertions;
using Loans.Domain.Applications.Values;
using NUnit.Framework;

namespace Loans.Tests
{
    public class LoanAmountShould
    {
        [Test]
        public void StoreCurrencyCode()
        {
            var loanAmount = new LoanAmount("usd", 100_000);
            //loanAmount.CurrencyCode.Should().Be("USD");
            loanAmount.CurrencyCode.Should().BeEquivalentTo("USD");
            //Assert.That(sut.CurrencyCode, Is.EqualTo("USD"));
        }
    }
}
