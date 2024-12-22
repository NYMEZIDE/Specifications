using Specification.Tests.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Specification.Tests.OnFalseActionsTests.Customs
{
    public class MRatingMovieSpec : AbstractSpec<Movie>
    {
        public override Expression<Func<Movie, bool>> Expression => m => m.MpaaRating == MpaaRating.M;
    }
}
