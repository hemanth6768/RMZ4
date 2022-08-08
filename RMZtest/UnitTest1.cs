using RMZ.Repository;
using System;
using Xunit;

namespace RMZtest
{
    public class UnitTest1
    {
        private readonly IGetinformation _repository;
        public UnitTest1(IGetinformation repository)
        {
            _repository= repository;    
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
