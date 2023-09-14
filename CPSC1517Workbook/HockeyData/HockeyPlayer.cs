using Hockey.Data;
using HockeyData;
using System.Runtime.InteropServices;

namespace Hockey.DataData
{
    public class HockeyPlayer
    {
        private string _birthplace;
        private DateOnly _dateOfBirth;
        private string _firstName;
        private int _heightInInches;
        private string _lastName;
        private int _weightInPounds;
        private Position _position;
        private Shot _shot;

        /*
        public void SetPosition(string value)
        {
            value = value.ToUpper();
            if (value == "LEFTWING" || )
            _position = value;
        }

        */
        public string BirthPlace
        {
            get
            {
                return _birthplace;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Birth place cannot be null or empty.");
                }
                _birthplace = value;
            }
        }

        public int HeightInInches
        {
            get
            {
                return _heightInInches;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Height must be positive.");
                }
                _heightInInches = value;
            }
        }

        public DateOnly DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }

            set
            {
                _dateOfBirth = value;
            }
        }

        public Position Position { get; set; }

        public Shot Shot { get; set; }


        public HockeyPlayer()
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            BirthPlace = string.Empty;
            DateOfBirth = new DateOnly();
            _weightInPounds = 0;
            HeightInInches = 0;
            Position = Position.Center;
        }

        public HockeyPlayer(string firstName, string lastName, string birthPlace, DateOnly birthDate, int weightInPounds, int heightInInches, Position position, Shot shot)
        {
            BirthPlace = birthPlace;
            HeightInInches = heightInInches;
            DateOfBirth = birthDate;
            Shot = shot;
            Position = position;
        }
    }
}