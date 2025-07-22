using Domain.Entities;
using Infrastructure.Entities;

namespace Infrastructure.Mappings;

public static class UserMappings
{
    public static UserEntity ToEntity(this User domainUser)
    {
        return new UserEntity
        {
            Id = domainUser.Id ?? 0,
            Name = domainUser.Name,
            Email = domainUser.Email,
            Role = (RoleEntity)domainUser.Role,
            UpdatedAt = DateTime.UtcNow
        };
    }

    public static User ToDomain(this UserEntity entity)
        => User.Create(entity.Name, entity.Email, (Role)entity.Role);

    public static void UpdateEntity(this UserEntity entity, User domainUser)
    {
        entity.Name = domainUser.Name;
        entity.Email = domainUser.Email;
        entity.Role = (RoleEntity)domainUser.Role;
        entity.UpdatedAt = DateTime.UtcNow;
    }
}