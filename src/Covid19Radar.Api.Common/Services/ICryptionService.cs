﻿namespace Covid19Radar.Api.Services
{
    public interface ICryptionService
    {
        string CreateSecret(string userUuid);
        bool ValidateSecret(string userUuid, string secret);
        string Protect(string secret);
        string Unprotect(string protectSecret);
    }
}
