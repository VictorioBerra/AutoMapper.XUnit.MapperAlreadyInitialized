namespace Host.Profiles
{
    using AutoMapper;
    using Host.Models;

    public class Profile1 : Profile
    {
        public Profile1()
        {
            CreateMap<A, B>()
                .ReverseMap();
        }
    }
}
