using Specification.Tests.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Specification.Tests.OnFalseActionsTests.Customs
{
    public class CustomActionOnFalseTests
    {
        [Fact]
        public void When_SpecIsClass_OnFalseActionInline()
        {
            Movie movie = new Movie()
            {
                MpaaRating = MpaaRating.G
            };

            var spec1 = new MRatingMovieSpec();

            var actionValue1 = false;
            var message = new StringBuilder();

            spec1.OnFalseAction = (s, c) =>
            {
                actionValue1 = true;
                message.Append("Movie is not M rating");
            };

            movie.Is(spec1);

            Assert.True(actionValue1);
            Assert.Equal("Movie is not M rating", message.ToString());
        }
    }
}
