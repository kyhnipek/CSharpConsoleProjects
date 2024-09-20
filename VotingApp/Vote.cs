namespace VotingApp
{
    public class Vote
    {
        Categories categories1 = new Categories();
        public void VoteCategory(int id)
        {
            categories1.CategoryList[categories1.CategoryList.FindIndex(item => item.CategoryId == id)].VoteCount++;
            Console.WriteLine("Oyunuz kaydedildi.");
            Utils.AddMinus();
            ShowVotingResults();
        }
        public void ShowVotingResults()
        {
            int totalVote = 0;
            double result = 0;
            foreach (var item in categories1.CategoryList)
            {
                totalVote += item.VoteCount;
                // Console.WriteLine(totalVote);
            }
            foreach (var item in categories1.CategoryList)
            {
                result = 100 * item.VoteCount / totalVote;
                Console.WriteLine("{0} oy yüzdesi: %{1} oy sayisi: {2} ", item.CategoryName, result, item.VoteCount);
            }

        }
    }
}