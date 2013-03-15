using System.Linq;
using System.Net;
using System.Xml.Linq;
using HtmlAgilityPack;
using NUnit.Framework;

namespace HippoValidator.JsHintValidator.Tests
{
    public class OptionsTest
    {
        [Test]
        public void AllOptionsFromDocumentationAreAddedToOptions()
        {
            // Arrange
            var html = new WebClient().DownloadString("http://www.jshint.com/docs/");
            var document = new HtmlDocument();
            document.LoadHtml(html);
            var tables = 
                document
                    .DocumentNode
                    .SelectNodes("//table[contains(@class,'options')]")
                    .Where(x => x.PreviousSibling.PreviousSibling.InnerText != "Directives");

            var trs = tables.Select(table => table.ChildNodes.Where(x => x.Name == "tr"));
            var options = trs.Select(t => t.Count(tr => !string.IsNullOrWhiteSpace(tr.ChildNodes.First(c => c.Name == "td").InnerText)));
            var expected = options.Sum();

            // Act
            var actual = typeof (Options).GetProperties().Length;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}