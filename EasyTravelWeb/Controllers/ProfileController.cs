using EasyTravelWeb.Repositories;
using System.Web.Http;
using System.Collections.Generic;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Models;
using System;
using System.Net;
using EasyTravelWeb.Infrastructure.Validators;
using Microsoft.AspNet.Identity;

namespace EasyTravelWeb.Controllers
{
    /// <summary>
    /// Controller for Profile page
    /// </summary>
    public class ProfileController : ApiController
    {
        #region Private Fields

        /// <summary>
        /// Instance of UserRepository, using methods to do actions with database
        /// </summary>
        private readonly UserRepository userRepository = new UserRepository();


        /// <summary>
        /// Instance of RatingRepository, using methods to do actions with database
        /// </summary>
        private readonly RatingRepository ratingRepository = new RatingRepository();

        /// <summary>
        /// Instance for stroring exceptions in file
        /// </summary>
        private readonly Logger logger = Logger.GetInstance();

        /// <summary>
        /// Validator fro first and lastn name
        /// </summary>
        private readonly IValidator<string> nameValidator =
            new NameChangingValidator();

        /// <summary>
        /// Instance of PlaceRepository, using method to get favourite places for user from database
        /// </summary>
        private readonly PlaceRepository placeRepository = new PlaceRepository();

        #endregion

        #region Constructors

        /// <summary>
        ///     Default constructor
        /// </summary>

        public ProfileController() { }

        /// <summary>
        ///    
        /// </summary>
        public ProfileController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        /// <summary>
        ///    
        /// </summary>
        public ProfileController(PlaceRepository placeRepository)
        {
            this.placeRepository = placeRepository;
        }

        #endregion

        #region Public Controllers

        /// <summary>
        /// Method for getting User from Db
        /// </summary>
        /// <param name="id">id of current user</param>
        /// <returns>First, last, email of user</returns>
        [Authorize]
        [HttpGet]
        [Route("api/Profile/GetUserInfo")]
        public IHttpActionResult GetUser(int id)
        {
            User user;
            try
            {
                user = this.userRepository.GetUser(id);

                if (user == null)
                {
                    return NotFound();
                }

            }
            catch (Exception ex)
            {
                this.logger.LogException(ex);

                return this.NotFound();
            }
            return Ok(user);
        }

        /// <summary>
        /// Method for changing first name of a user
        /// </summary>
        /// <param name="id">Id of current user</param>
        /// <param name="firstName">First name which will be updated in database</param>
        /// <returns>result of chaning (Bad or Ok)</returns>
        [Authorize]
        [HttpPost]
        [Route("api/Profile/ChangeFirstName")]
        public IHttpActionResult ChangeFirstName(int id, string firstName)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            if (this.nameValidator.IsValid(firstName))
            {
                try
                {
                    this.userRepository.ChangeFirstName(id, firstName);
                }
                catch (Exception ex)
                {
                    this.logger.LogException(ex);

                    return this.BadRequest();
                }
            }

            return this.Ok();
        }

        /// <summary>
        /// Method for changing first name of a user
        /// </summary>
        /// <param name="id">Id of current user</param>
        /// <param name="lastName">Last name which will be updated in database</param>
        /// <returns>result of chaning (Bad or Ok)</returns>
        [Authorize]
        [HttpPost]
        [Route("api/Profile/ChangeLastName")]
        public IHttpActionResult ChangeLastName(int id, string lastName)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            if (this.nameValidator.IsValid(lastName))
            {
                try
                {
                    this.userRepository.ChangeLastName(id, lastName);
                }
                catch (Exception ex)
                {
                    this.logger.LogException(ex);

                    return this.BadRequest();
                }
            }

            return this.Ok();
        }

        /// <summary>
        /// Cotroler fo getting favorite places of specific user
        /// </summary>
        /// <returns>List of favourite Places</returns>
        [Authorize]
        [HttpGet]
        [Route("api/Profile/GetFavoritePlaces")]
        public IHttpActionResult GetFavoritePlaces(int id)
        {
            try
            {
                List<Place> cityPlaces = this.placeRepository.GetFavoritePlaces(id);

                if (cityPlaces != null)
                {
                    return this.Ok(cityPlaces);
                }

                return this.NotFound();
            }
            catch (Exception ex)
            {
                this.logger.LogException(ex);

                return this.NotFound();
            }

        }


        /// <summary>
        /// Cotroller fo setting rating place of specific user
        /// </summary>
        /// <returns>List of favourite Places</returns>
        [Authorize]
        [HttpPost]
        //[Route("api/Profile/GetFavoritePlaces")]
        public IHttpActionResult SetUserRatingForPlace([FromBody] UserPlaceRating userRating)
        {
            try
            {
                if (ratingRepository.SetUserRatingForPlace(userRating))
                {
                    return Ok();
                }

                return Content(HttpStatusCode.BadRequest, "You already add this place to favourite");
            }
            catch (Exception ex)
            {
                this.logger.LogException(ex);
                return InternalServerError();
            }
        }

        /// <summary>
        /// Cotroller fo setting rating place of specific user
        /// </summary>
        /// <returns>List of favourite Places</returns>
        [Authorize]
        [HttpGet]
        public IHttpActionResult GetUserRatingOfPlace(int userId, long placeId)
        {
            try
            {
                return Ok(ratingRepository.GetUserRatingOfPlace(userId, placeId));                
            }
            catch (Exception ex)
            {
                this.logger.LogException(ex);
                return InternalServerError();
            }
        }

        #endregion
    }
}
