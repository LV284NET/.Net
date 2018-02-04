using EasyTravelWeb.Repositories;
using EasyTravelWeb.Models;
using NUnit.Framework;

namespace EasyTravelTest.RepositoriesTest
{
    [TestFixture]
    class RatingRepositoryTest
    {
        private RatingRepository ratingRepository = new RatingRepository();

        [Test]
        public void SetUserRatingForPlaceTest()
        {
            Assert.True(ratingRepository.SetUserRatingForPlace(new UserPlaceRating()
            {
                UserId = 1,
                PlaceId = 1,
                Rating = 4                
            }));
        }

        [Test]
        public void DeleteUserRatingForPlaceTest()
        {
            ratingRepository.SetUserRatingForPlace(new UserPlaceRating()
            {
                UserId = 1,
                PlaceId = 2,
                Rating = 4
            });

            Assert.True(ratingRepository.DeleteUserRatingForPlace(1, 2));
        }

        [Test]
        public void UserRatingOfPlace()
        {
            Assert.GreaterOrEqual(ratingRepository.GetUserRatingOfPlace(1, 4), 0);
        }
    }
}
