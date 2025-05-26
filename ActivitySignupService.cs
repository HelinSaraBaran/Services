using System.Collections.Generic;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Repositories;

namespace Service
{
    // Service der håndterer logik for aktivitetstilmeldinger
    public class ActivitySignupService
    {
        private IActivitySignupRepository _repository; // Repository til datahåndtering

        // Constructor – opretter repository-instans
        public ActivitySignupService()
        {
            _repository = new ActivitySignupRepository();
        }

        // Tilføjer en ny tilmelding
        public void AddSignup(ActivitySignup signup)
        {
            _repository.Add(signup);
        }

        // Henter alle tilmeldinger
        public List<ActivitySignup> GetAllSignups()
        {
            return _repository.GetAll();
        }

        // Gemmer hele tilmeldingslisten
        public void SaveAll(List<ActivitySignup> signups)
        {
            _repository.SaveAll(signups);
        }
    }
}
