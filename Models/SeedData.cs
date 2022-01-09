using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using zheITHome.Data;
using System;
using System.Linq;
using zheITHome.Models;

namespace zheITHome.Models
{
    public class SeedData
    {
         public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new zheITHomeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<zheITHomeContext>>()))
            {
                // Look for any movies.
                if (context.Article.Any())
                {
                    return;   // DB has been seeded
                }

                context.Article.AddRange(
                    new Article
                    {
                        Title = "Day01 Azure 的自我修煉",
                        ReleaseDate = DateTime.Parse("2020-09-01"),
                        Link = "https://ithelp.ithome.com.tw/articles/10233277",
                        Count = 0
                    },

                    new Article
                    {
                        Title = "Day02 申請Azure帳號",
                        ReleaseDate = DateTime.Parse("2020-09-02"),
                        Link = "https://ithelp.ithome.com.tw/articles/10233285",
                        Count = 0
                    },

                    new Article
                    {
                        Title = "Day03 Resource Group 資源群組",
                        ReleaseDate = DateTime.Parse("2020-09-03"),
                        Link = "https://ithelp.ithome.com.tw/articles/10233371",
                        Count = 0
                    },

                    new Article
                    {
                        Title = "Day04 Dotnet Core 專案",
                        ReleaseDate = DateTime.Parse("2020-09-04"),
                        Link = "https://ithelp.ithome.com.tw/articles/10233562",
                        Count = 0
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
