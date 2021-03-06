using NUnit.Framework;

namespace HdrHistogram.UnitTests.Persistence
{
    [TestFixture]
    public sealed class IntConcurrentHistogramLogReaderWriterTests : HistogramLogReaderWriterTestBase
    {
        protected override HistogramBase Create(long highestTrackableValue, int numberOfSignificantValueDigits)
        {
            return new IntConcurrentHistogram(1, highestTrackableValue, numberOfSignificantValueDigits);
        }

        [Test, TestCaseSource(typeof(TestCaseGenerator), nameof(TestCaseGenerator.PowersOfTwo), new object[] { 31 })]
        public void CanRoundTripSingleHistogramsWithFullRangesOfCountsAndValues(long count)
        {
            RoundTripSingleHistogramsWithFullRangesOfCountsAndValues(count);
        }
    }
}