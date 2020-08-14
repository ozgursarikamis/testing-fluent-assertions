﻿using FluentAssertions;
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
            // loanAmount.CurrencyCode.Should().Be("USD");
            // loanAmount.CurrencyCode.Should().BeEquivalentTo("USD");
            loanAmount.CurrencyCode.Should().Contain("S");
            loanAmount.CurrencyCode.Should().StartWith("U");
            loanAmount.CurrencyCode.Should().EndWith("D");
            loanAmount.CurrencyCode.Should().BeOneOf("USD", "AUD", "GBP");

            loanAmount.CurrencyCode.Should().Match("*D");
            loanAmount.CurrencyCode.Should().Match("*S*");
            loanAmount.CurrencyCode.Should().MatchRegex("[A-Z]{3}");
        }
    }
}
