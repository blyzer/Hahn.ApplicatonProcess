using System;

namespace Hahn.ApplicatonProcess.December2020.Domain
{
    /// <summary>
    /// Applicant to job
    /// </summary>
    public class Applicant
    {
        /// <summary>
        /// Constructor of the class <see cref="Applicant"/>
        /// </summary>
        /// <param name="name"><see cref="Applicant.Name"/></param>
        /// <param name="familyName"><see cref="Applicant.FamilyName"/></param>
        /// <param name="address"><see cref="Applicant.Address"/></param>
        /// <param name="countryOfOrigin"><see cref="Applicant.CountryOfOrigin"/></param>
        /// <param name="emailAddress"><see cref="Applicant.EMailAdress"/></param>
        /// <param name="age"><see cref="Applicant.Age"/></param>
        /// <param name="hired"><see cref="Applicant.Hired"/></param>
        public Applicant(string name, string familyName, string address, string countryOfOrigin, string emailAddress,
            int age, bool hired)
        {
            Name = name;
            FamilyName = familyName;
            Address = address;
            CountryOfOrigin = countryOfOrigin;
            EMailAdress = emailAddress;
            Age = age;
            Hired = hired;
        }

        /// <summary>
        /// Candidate's Identification
        /// </summary>
        /// <value><see cref="int"/></value>
        public int Id { get; set; }

        /// <summary>
        /// Candidate's Name
        /// </summary>
        /// <value><see cref="string"/></value>
        public string Name { get; private set; }

        /// <summary>
        /// Candidate's Lastname
        /// </summary>
        /// <value><see cref="string"/></value>
        public string FamilyName { get; private set; }

        /// <summary>
        /// Candidate's Address
        /// </summary>
        /// <value><see cref="string"/></value>
        public string Address { get; private set; }

        /// <summary>
        /// candidate's country of origin
        /// </summary>
        /// <value><see cref="string"/></value>
        public string CountryOfOrigin { get; private set; }

        /// <summary>
        /// Candidate's Email
        /// </summary>
        /// <value><see cref="string"/></value>
        public string EMailAdress { get; private set; }

        /// <summary>
        /// Candidate's age
        /// </summary>
        /// <value><see cref="int"/></value>
        public int Age { get; private set; }

        /// <summary>
        /// check if applicant was hired
        /// </summary>
        /// <value><see cref="bool"></value>
        public bool Hired { get; private set; }
    }
}
