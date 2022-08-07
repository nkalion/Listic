using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Users.Resources;

namespace Users.Extensions;

public static class MappingExtensions
{
    public static Profile AccountMappings(this Profile profile)
    {
        profile.CreateMap<UserCredentialsResource, IdentityUser>();

        return profile;
    }
}