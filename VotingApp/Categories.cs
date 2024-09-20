namespace VotingApp
{
    class Categories
    {
        private int categoryId;
        private string categoryName;
        private int voteCount;

        private List<Categories> categoryList = new List<Categories>();


        public Categories()
        {
            categoryList.Add(new Categories(categoryId = 1, categoryName = "Aksiyon", voteCount = 10));
            categoryList.Add(new Categories(categoryId = 2, categoryName = "Dram", voteCount = 8));
            categoryList.Add(new Categories(categoryId = 3, categoryName = "Korku", voteCount = 5));
            categoryList.Add(new Categories(categoryId = 4, categoryName = "Komedi", voteCount = 15));
            categoryList.Add(new Categories(categoryId = 5, categoryName = "Romantik Komedi", voteCount = 12));
        }

        public Categories(int categoryId, string categoryName, int voteCount)
        {
            this.categoryName = categoryName;
            this.voteCount = voteCount;
            this.categoryId = categoryId;
        }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public int VoteCount { get => voteCount; set => voteCount = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public List<Categories> CategoryList { get => categoryList; set => categoryList = value; }

        public void ListCategories()
        {
            foreach (var category in CategoryList)
            {
                Console.WriteLine(" ({0}) {1}", category.categoryId, category.CategoryName);
            }
            Utils.AddMinus();
        }

    }
}