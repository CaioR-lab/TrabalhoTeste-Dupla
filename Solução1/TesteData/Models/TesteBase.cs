using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TesteData.Models
{
    public class TesteBase
    {
        [Fact]
        public void TesteInstanciaBase()
        {
            //arrange
            //act
            Action ab = () => Activator.CreateInstance<Base>();
            //assert
            Assert.Throws<MissingMethodException>(ab);
        }

    }
}
