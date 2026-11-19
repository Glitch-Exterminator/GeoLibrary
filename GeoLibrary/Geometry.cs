namespace GeoLibrary
{
	internal class Geometry
	{
		public static double GetLength(Vector vector)
			=> Math.Sqrt(Math.Pow(vector.X, 2) + Math.Pow(vector.Y, 2));

		public static Vector Add(Vector vector1, Vector vector2)
			=> new Vector(vector1.X + vector2.X, vector1.Y + vector2.Y);
	}
}