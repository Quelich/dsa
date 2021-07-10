namespace SOLs
{
    // INCOMPLETE : LEARN BIT MASKING
    public class CombinationIterator
    {
        private string Characters { get; set; }
        private int CombinationLength { get; set; }
        public CombinationIterator(string characters, int combinationLength)
        {
            Characters = characters;
            CombinationLength = combinationLength;
        }
    
        public string Next()
        {
            return string.Empty;
        }
    
        public bool HasNext()
        {
            return true;
        }   
    }

    // class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         
    //     }
    // }
}