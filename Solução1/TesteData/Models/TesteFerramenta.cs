using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TesteData.Models
{
    public class TesteFerramenta
    {
        [Fact]
        public void TesteHerancaFerramentaBase()
        {
            //arrange
            Ferramenta f;
            //act
            f = new Ferramenta();
            //assert
            Assert.IsAssignableFrom<Base>(f);
        }

        //[Fact]
        //public void TestePropriedadeNomeFerramenta()
        //{
        //    //arrange
        //    Ferramenta f = new Ferramenta();
        //    //act
        //    f.Nome = "caio";
        //    //assert
        //    Assert.
        //}

        [Fact]
        public void TestePropriedadeFerramentaPeso()
        {
            //arrange
            Ferramenta f = new Ferramenta();
            //Act
            f.Peso = 100.51210215F;
            float test = 100.51210215F;
            //Assert
            Assert.Equal(test, f.Peso);
        }
    }
}
