namespace Library.Domain.Features.Publish
{
	public interface IPublishService
	{
		void BookPublication(string title, string authorName);
	}
}