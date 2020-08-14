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
            var loanAmount = new LoanAmount("USD", 100_000);
            loanAmount.CurrencyCode.Should().Be("USD");
            //Assert.That(sut.CurrencyCode, Is.EqualTo("USD"));
        }
    }
}
