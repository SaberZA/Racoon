using System;
using System.Diagnostics;
using System.Threading;
using NUnit.Framework;
using Racoon.Data;
using StackExchange.Redis;

namespace Racoon.Test
{
    [TestFixture]
    public class RedisTest
    {
        private RedisContext _redisContext;
        
        [Test]
        public void TestGet_GivenMyKey_ShouldReturnHello()
        {
            //---------------Set up test pack-------------------
            
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var testRepo = new RedisRepository(_redisContext);
            var testObject = testRepo.GetById("mykey");
            //---------------Test Result -----------------------
            Assert.AreEqual("Hello",testObject.Value);
        }
        



        // Ops

        [Test]
        public void TestConnection()
        {
            //---------------Set up test pack-------------------
            
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var conn = ConnectionMultiplexer.Connect("localhost");
            //---------------Test Result -----------------------
            Debug.WriteLine(conn.IsConnected);
            conn.Close();
        }

        [TestFixtureSetUp]
        private void Setup()
        {
            _redisContext = new RedisContext();
        }

        [TestFixtureTearDown]
        private void TearDown()
        {
            _redisContext.Close(true);
        }
    }

    public class TestObject : IBusinessObject
    {
        public String Key { get; set; }
        public String Value { get; set; }
    }
}
