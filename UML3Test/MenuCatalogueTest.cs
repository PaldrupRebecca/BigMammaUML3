using BigMammaUML3;

namespace UML3Test
{
    [TestClass]
    public class MenuCatalogueTest
    {
        [TestMethod]
        public void TestAdd()
        {
            //Arrange
            IMenuCatalogue catalogue;
            catalogue = new MenuCatalogue();

            Pizza p1 = new Pizza(1, "Vesuvio", "tomat, oliven, ost", 85, MenuType.Pizza, false, true, false);
            Pizza p2 = new Pizza(2, "Hawaii", "tomat, ost, skinke, ananas", 75, MenuType.Pizza, false, true, true);

            //Act
            int amountBefore = catalogue.Count;
            catalogue.Add(p1);
            catalogue.Add(p2);
            int amountAfter = catalogue.Count;

            //Assert
            Assert.AreEqual(amountBefore + 2, amountAfter);
        }

        [TestMethod]
        public void TestSearch()
        {
            IMenuCatalogue catalogue;
            catalogue = new MenuCatalogue();
            Pizza p1 = new Pizza(1, "Vesuvio", "tomat, oliven, ost", 85, MenuType.Pizza, false, true, false);
            Pizza p2 = new Pizza(2, "Hawaii", "tomat, ost, skinke, ananas", 75, MenuType.Pizza, false, true, true);
            catalogue.Add(p1);
            catalogue.Add(p2);

            IMenuItem foundItem = catalogue.Search(2);
            
            Assert.AreEqual(foundItem.Number, 2);
        }

        [TestMethod]
        public void TestMostExpensive()
        {
            IMenuCatalogue catalogue;
            catalogue = new MenuCatalogue();
            Pizza p1 = new Pizza(1, "Vesuvio", "tomat, oliven, ost", 85, MenuType.Pizza, false, true, false);
            Pizza p2 = new Pizza(2, "Hawaii", "tomat, ost, skinke, ananas", 75, MenuType.Pizza, false, true, true);
            catalogue.Add(p1);
            catalogue.Add(p2);

            IMenuItem mostExpensiveItem = catalogue.MostExpensiveMenuItem();

            Assert.AreEqual(mostExpensiveItem.Price, 85);
        }
    }
}