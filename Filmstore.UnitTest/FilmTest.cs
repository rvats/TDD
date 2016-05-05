using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmstore.UnitTest
{
    class FilmTest
    {
        [Test]
        public void ConstructorShouldSetProperties()
        {
            //arrange
            //act
            Film film = new Film("Aliens", new DateTime(1984, 1, 20), 5 Genre.Science_Fiction);
            //assert
            Assert.AreEqual("Aliens", film.Title);
            Assert.AreEqual(new DateTime(1984, 1, 20), film.Released);
            Assert.AreEqual(5, film.Stock);
            Assert.AreEqual(Genre.Science_Fiction, film.Genre);
        }
    }
}
