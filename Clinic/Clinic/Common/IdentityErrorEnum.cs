using System.ComponentModel;

namespace Clinic.Common;

enum IdentityErrorEnum
{
    [Description("Логин должен быть уникальным.")]
    DuplicateUserName,
    [Description("Логин должен состоять из латинских букв и цифр.")]
    InvalidUserName,
    [Description("")]
    EmptyString,
    [Description("Пароль должен содержать минимум 6 символов.")]
    PasswordTooShort,
    [Description("Пароль должен содержать хотя бы один специальный символ.")]
    PasswordRequiresNonAlphanumeric,
    [Description("Пароль должен содержать хотя бы одну цифру ('0'-'9').")]
    PasswordRequiresDigit,
    [Description("Пароль должен содержать хотя бы одну строчную букву ('a'-'z').")]
    PasswordRequiresLower,
    [Description("Пароль должен содержать хотя бы одну заглавную букву ('A'-'Z').")]
    PasswordRequiresUpper
};
