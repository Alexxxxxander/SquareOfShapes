using SquareOfShapes;
namespace TestSquareOfShapes
{
    public class Tests
    {

        [Test]
        public void GetAreaCircle_radius10_314()
        {
            Circle circle = new Circle(10);
            Assert.That(circle.Area, Is.EqualTo(Math.PI * 10 * 10));
        }

        [Test]
        public void GetAreaTriangle_a3b4c5_6()
        {
            Triangle triangle = new Triangle(3,4,5);
            Assert.That(triangle.Area, Is.EqualTo(6));
        }

        [Test]
        public void GetAreaTriangle_negativea3b4c5_6()
        {
            Triangle triangle = new Triangle(-3, -4, -5);
            Assert.That(triangle.Area, Is.EqualTo(6));
        }

        [Test]
        public void IsTriangeRight_a3b4c5_true()
        {
            Triangle triangle= new Triangle(3,4,5);
            Assert.IsTrue(triangle.IsRight);
        }
    }
}