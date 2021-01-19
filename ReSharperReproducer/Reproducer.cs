//
// This file contains a reproducer for a ReSharper bug.
//

namespace ReSharperReproducer
{
    public class Reproducer
    {
        public void ReproducerMethod()
        {
            // ReSharper disable UnusedParameter.Local
            static void RunTest<T>(T notNullValue, T nullValue)
            // ReSharper restore UnusedParameter.Local
            {
            }

            RunTest<string?>("abc", null);
            //RunTest("abc", null); // creates: CS8625: Cannot convert null literal to non-nullable reference type.
        }
    }
}
