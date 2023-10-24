namespace MyBGList_ApiVersion.DTO.v2
{
    public class RestDTO<T>
    {
        public List<v1.LinkDTO> Links { get; set; } = new List<v1.LinkDTO>();
        public T Items { get; set; } = default!;
    }
}
