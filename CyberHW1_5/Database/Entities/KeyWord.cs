using System.ComponentModel.DataAnnotations;

namespace ShopMVP.Database.Entities
{
    public class KeyWord
    {
        public Guid KeyWordId { get; set; }
        [MaxLength(24)]
        public string Word { get; set; }
        public int Count { get; set; }
        public List<KeyParams>?  ProductLink { get; set; }

        public KeyWord(string Word) 
        { 
            KeyWordId = Guid.NewGuid();
            this.Word = Word;
            Count = 0;
        }
        public KeyWord(string word, List<KeyParams>? productLink)
        {
            KeyWordId = Guid.NewGuid();
            this.Word = word;
            this.ProductLink = productLink;
            Count = 0;
        }
    }
}
