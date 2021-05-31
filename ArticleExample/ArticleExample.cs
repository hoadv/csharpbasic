using System;
using System.Collections.Generic;
using System.Linq;


public class ArticleExample
{
    private static readonly IList<Article> ArticleList = new List<Article>()
            {
                new Article("Title 1", "Description 1"),
                new Article("Title 2", "Description 2"),
                new Article("Title 3", "Description 3"),
                new Article("Title 4", "Description 4"),
                new Article("Title 5", "Description 5"),
                new Article("Title 6", "Description 6"),
                new Article("Title 7", "Description 7")
            };

    public class Article
    {
        public Article(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class GetArticleResponse
    {
        public IList<Article> Articles { get; set; }
        public string NextPageToken { get; set; }
    }

    public class DataService
    {
        private const int MaxRetrivedItems = 2;

        public GetArticleResponse GetArticles(string nextPageToken = null)
        {
            nextPageToken ??= "0";

            var response = new GetArticleResponse()
            {
                Articles = null,
                NextPageToken = null
            };

            if (int.TryParse(nextPageToken, out var fromPage))
            {
                var satisfiedArticles = ArticleList.Skip(fromPage).Take(MaxRetrivedItems).ToList();

                response.Articles = satisfiedArticles;

                if (ArticleList.Count > (fromPage + MaxRetrivedItems))
                {
                    response.NextPageToken = $"{fromPage + MaxRetrivedItems}";
                }
            }

            return response;
        }
    }

    static void Main(string[] args)
    {
        // Requirement: Get all 7 articles by calling dataService.GetArticles.
        // The GetArticles will only allow you to get 2 item per request.
        // The NextPageToken will be returned if there is any remaining items. Otherwise, NextPageToken = null
        // Only using one loop (for, while, do while, foreach) to fetch all articles.
        var articles = GetAllArticles();
        CheckResult(articles);
    }

    // >>>>>>>>>>>>>>> YOU CODE HERE!<<<<<<<<<<<<<<<<<<<<<<<<
    private static IList<Article> GetAllArticles()
    {
        var dataService = new DataService();
        var articles = new List<Article>();

        // You code will come from here
        var getArticleResponse = new GetArticleResponse();

        do
        {
            getArticleResponse = dataService.GetArticles(getArticleResponse.NextPageToken);
            articles.AddRange(getArticleResponse.Articles);

        } while (getArticleResponse.NextPageToken != null);

        return articles;
    }


    // DO NOT TOUCH ===============================
    private static void CheckResult(IList<Article> articles)
    {
        if (Enumerable.SequenceEqual(articles, ArticleList))
        {
            printO();
            printK();
            Console.Write("============================");
            Console.Write("\n");
            printH();
        }
        else
        {
            printN();
            printO();
            printN();
        }

    }

    // Number of lines for the alphabet's pattern
    private static int height = 5;

    // Number of character width in each line
    private static int width = (2 * height) - 1;

    // Function to find the absolute value
    // of a number D
    private static int abs(int d)
    {
        return d < 0 ? -1 * d : d;
    }

    private static void printO()
    {
        int i, j, space = (height / 3);
        int width = height / 2 + height / 5 + space + space;
        for (i = 0; i < height; i++)
        {
            for (j = 0; j <= width; j++)
            {
                if (j == width - abs(space)
                    || j == abs(space))
                    Console.Write("*");
                else if ((i == 0
                        || i == height - 1)
                        && j > abs(space)
                        && j < width - abs(space))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            if (space != 0
                && i < height / 2)
            {
                space--;
            }
            else if (i >= (height / 2 + height / 5))
                space--;
            Console.Write("\n");
        }
    }

    // Function to print the pattern of 'K'
    private static void printK()
    {
        int i, j, half = height / 2, dummy = half;
        for (i = 0; i < height; i++)
        {
            Console.Write("*");
            for (j = 0; j <= half; j++)
            {
                if (j == abs(dummy))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.Write("\n");
            dummy--;
        }
    }

    // Function to print the pattern of 'N'
    private static void printN()
    {
        int i, j, counter = 0;
        for (i = 0; i < height; i++)
        {
            Console.Write("*");
            for (j = 0; j <= height; j++)
            {
                if (j == height)
                    Console.Write("*");
                else if (j == counter)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            counter++;
            Console.Write("\n");
        }
    }

    private static void printH()
    {
        int row, column;

        for (row = 0; row <= 6; row++)
        {
            for (column = 0; column <= 6; column++)
            {
                if ((column == 1 || column == 5) || (row == 3 && column > 1 && column < 6))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.Write("\n");
        }
        Console.Write("\n");
    }
}