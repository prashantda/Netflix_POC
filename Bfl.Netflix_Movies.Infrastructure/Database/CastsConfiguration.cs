using Bfl.Netflix.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix.Infrastructure.Database
{
    public class CastsConfiguration : IEntityTypeConfiguration<Cast>
    {
        public void Configure(EntityTypeBuilder<Cast> builder)
        {
            builder.HasData(new Cast() { CastId= Guid.Parse("9245e61d-20cf-4fee-aaae-d261182f8f69"), CastName = "Aamir Khan" },
                new Cast() { CastId = Guid.Parse("d39b6791-1330-465f-99b5-3a537c1b9758"), CastName = "Akshay Kumar" },
                new Cast() { CastId = Guid.Parse("72474143-14a5-4727-9ecc-e87bf7a32d9e"), CastName = "Ajay Devgn" },
                new Cast() { CastId = Guid.Parse("4301810d-ecce-4e5a-be0d-dcd1106f0fc3"), CastName = "Amjad Khan" },
                new Cast() { CastId = Guid.Parse("989efc3e-aab9-489c-813e-e5a0bee7b754"), CastName = "Amitabh Bachchan" },
                new Cast() { CastId = Guid.Parse("a02815a4-0f1b-4e43-89fa-cb231ad8ed11"), CastName = "Amol Palekar" },
                new Cast() { CastId = Guid.Parse("57632fe9-017d-41c4-8d4e-28571dbd8d87"), CastName = "Akshay Khanna" },
                new Cast() { CastId = Guid.Parse("8e6f2587-5183-4baf-9d44-39bc0b6f67da"), CastName = "Anushka Shetty" },
                new Cast() { CastId = Guid.Parse("a9b82b2f-d28b-46bb-a86b-fd0828636751"), CastName = "Ayushmann Khurrana" },
                new Cast() { CastId = Guid.Parse("e62fe11d-52d0-4a25-8505-f9a4c84a3cee"), CastName = "Anil Kapoor" },
                new Cast() { CastId = Guid.Parse("67461f57-a5d8-459c-a90c-4da75d0890a7"), CastName = "Deepika Padukone" },
                new Cast() { CastId = Guid.Parse("200d1941-a014-4179-afcc-bf15bf0a17ed"), CastName = "Madhuri Dixit" },
                new Cast() { CastId = Guid.Parse("27eafb12-057a-4d7f-8181-320ac73a8531"), CastName = "Madhubala" },
                new Cast() { CastId = Guid.Parse("8cf650c8-77fc-45bc-acb4-0a306923a5e9"), CastName = "Rajkummar Rao" },
                new Cast() { CastId = Guid.Parse("6c1b7706-a0b6-4b2d-951c-18144e5c5386"), CastName = "Tabu" },
                new Cast() { CastId = Guid.Parse("1b29488f-e330-42b9-9b61-78121f9c0230"), CastName = "Tapasi Pannu" },
                new Cast() { CastId = Guid.Parse("fd68d09c-29bc-4e97-909a-2c5360ddf582"), CastName = "Samantha Prabhu" },
                new Cast() { CastId = Guid.Parse("0f83f70f-6d89-42f3-953f-5ea5729be362"), CastName = "Sai Pallavi" },
                new Cast() { CastId = Guid.Parse("66f46881-e918-42a4-8dce-803ca8e5b210"), CastName = "Shradhaa Kapoor" },
                new Cast() { CastId = Guid.Parse("7ad3d36b-58c5-416d-a34e-c1f5460feb31"), CastName = "Ranvir Kapoor" },
                new Cast() { CastId = Guid.Parse("5da44770-40ce-450b-b3df-0255ddb9a299"), CastName = "Aliya Bhatt" },
                new Cast() { CastId = Guid.Parse("d9b15da5-7058-4474-ae67-766d462785b3"), CastName = "Kiaara Adavani" },
                new Cast() { CastId = Guid.Parse("ad529778-2e1c-4b2d-a9bf-10d8cc1f0791"), CastName = "Sushant Sing Rajpoot" },
                new Cast() { CastId = Guid.Parse("a6e6fae2-51d8-4c54-92f9-713917f823b7"), CastName = "ABC" }
                );
        }
    }
}
