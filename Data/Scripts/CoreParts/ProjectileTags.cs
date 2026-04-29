using static Scripts.Structure;
using static Scripts.Structure.ProjectileTagDefinition;
using static Scripts.Structure.ProjectileTagAssignment;

namespace Scripts
{
    partial class Parts
    {
        // Don't edit above this line
        ProjectileTagDefinition ExampleTag1Def => new ProjectileTagDefinition
        {
            Namespace = new Tag
            {
                ID = "examplecoreparts", // internal name
                PublicName = "Your Mod Name Here", // Public facing name
            },
            DefinitionPriority = 0,
            Tags = new[]
            {
                new Tag 
                {
                    ID = "cannon", 
                    PublicName = "Cannon"
                },
                new Tag 
                {
                    ID = "stealth",
                    PublicName = "Stealth Projectile"
                },
                new Tag 
                {
                    ID = "small",
                    PublicName = "Small"
                },
                new Tag 
                {
                    ID = "large",
                    PublicName = "Large"
                },
            },
        };

        ProjectileTagAssignment[] ExampleTagAssignments => new[]
        {
            new ProjectileTagAssignment
            {
                Tag = "yourmodhere:stealth",
                ProjectileAmmoNames = new[]
                {
                    "Ammo 1",
                },
            },
            new ProjectileTagAssignment
            {
                Tag = "yourmodhere:small",
                ProjectileAmmoNames = new[]
                {
                    "Ammo 1",
                },
            }
        };
    }
}
