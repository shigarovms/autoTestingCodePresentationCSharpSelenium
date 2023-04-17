using Aquality.Selenium.Core.Elements;
using Aquality.Selenium.Core.Elements.Interfaces;
using OpenQA.Selenium;

namespace a1qa_L2_UserInterface.Extensions
{
    public static class ElementFactoryExtensions
    {
        public static IList<T> GetNotEmptyElementList<T>(this IElementFactory elementFactory, By by, string itemName) where T : IElement
        {
            try
            {
                return elementFactory.FindElements<T>(by, expectedCount: ElementsCount.MoreThenZero);
            }
            catch (TimeoutException e)
            {
                throw new TimeoutException($"Elements [{itemName}] were not found by locator [{by}]", e);
            }
        }
    }
}
