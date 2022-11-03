using CodingTest;

namespace Test
{
    public class Tests
    {
        private Router _router;

        [SetUp]
        public void Setup()
        {
            _router = new Router();
            _router.withRoute("/foo/baz", "blip");
            _router.withRoute("/baz/foo", "blob");
            _router.withRoute("/foo", "blipbblob");
        }

        [TestCase("/foo/baz", "blip")]
        [TestCase("/baz/foo", "blob")]
        [TestCase("/foo" , "blipbblob")]
        public void AssessMultpleValue(string path, string function)
        {
            string result = _router.route(path);
            Assert.That(result, Is.EqualTo(function));
        }
        [Test]
        public void AssertException()
        {
            string path = "abc";
            Assert.Throws<KeyNotFoundException>((() => _router.route("abc")));
        }
    }
}