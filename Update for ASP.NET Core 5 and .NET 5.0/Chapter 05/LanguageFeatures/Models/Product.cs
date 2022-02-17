namespace LanguageFeatures.Models {
    public class Product {

        // Constructor
        // assign a read-only property a default value
        
        // public Product(bool stock = true) {
        //     InStock = stock;                   //  Init a read-only property
        // }

        public string Name { get; set; }
        public string Category { get; set; } = "Watersports";  // default value
        public decimal? Price { get; set; }
        public Product Related { get; set; }   // Notice the Type is "Product"
        public bool InStock { get; init; } = true;          // Read only, After initiation, it cannot be changed    
        public bool NameBeginsWithS => Name?[0] == 'S';

        public static Product[] GetProducts() {

            Product kayak = new Product {
                Name = "Kayak",
                Category = "Water Craft",
                Price = 275M
            };
            
            // assign another value to the read-only peoperty
            //Product lifejacket = new Product(false) {
            Product lifejacket = new Product {
                Name = "Lifejacket",
                Price = 48.95M,
                InStock = false
            };

            kayak.Related = lifejacket;     //  Notice how to define relationship within a Type definition itself ! 
            
            // There is a Null record here !
            return new Product[] { kayak, lifejacket, null };
        }
    }
}
