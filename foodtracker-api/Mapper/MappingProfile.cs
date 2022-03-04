using AutoMapper;
using foodtracker_db.Models;

namespace foodtracker_api.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //Create Restorant
            CreateMap<CreateRestorantModel,Restorant>();
            //For Update
            CreateMap<Restorant,CreateRestorantModel>();
            //Create Comment
            CreateMap<CreateCommentModel,Comment>();
        }
    }
}