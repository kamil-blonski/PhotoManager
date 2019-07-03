namespace PhotoManager.Model
{
    public class Camera
	{
		string type;
		User owner;

		public Camera(string type, User owner)
		{
			this.type = type;
			this.owner = owner;
		}
	}
}
