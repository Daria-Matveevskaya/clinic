using Clinic.Common;
using Microsoft.AspNetCore.Identity;

namespace Clinic.Identity
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {

        public override IdentityError DuplicateUserName(string userName) => new() { Code = nameof(DuplicateUserName), Description = IdentityErrorEnum.DuplicateUserName.GetDescription() };
        public override IdentityError InvalidUserName(string? userName) => new() { Code = nameof(InvalidUserName), Description = IdentityErrorEnum.InvalidUserName.GetDescription() };
        public override IdentityError PasswordTooShort(int length) => new() { Code = nameof(PasswordTooShort), Description = IdentityErrorEnum.PasswordTooShort.GetDescription() };
        public override IdentityError PasswordRequiresNonAlphanumeric() => new() { Code = nameof(PasswordRequiresNonAlphanumeric), Description = IdentityErrorEnum.PasswordRequiresNonAlphanumeric.GetDescription() };
        public override IdentityError PasswordRequiresDigit() => new() { Code = nameof(PasswordRequiresDigit), Description = IdentityErrorEnum.PasswordRequiresDigit.GetDescription() };
        public override IdentityError PasswordRequiresLower() => new() { Code = nameof(PasswordRequiresLower), Description = IdentityErrorEnum.PasswordRequiresLower.GetDescription() };
        public override IdentityError PasswordRequiresUpper() => new() { Code = nameof(PasswordRequiresUpper), Description = IdentityErrorEnum.PasswordRequiresUpper.GetDescription() };

}
}