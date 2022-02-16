using System.Collections.Generic;

/*
 * Use a static class to work as a repository
 * Very neat and smart.
 */

namespace PartyInvites.Models {
    public static class Repository {
        
        // a private element as internal data container
        private static List<GuestResponse> responses = new List<GuestResponse>();

        // a property as interface
        public static IEnumerable<GuestResponse> Responses => responses;

        public static void AddResponse(GuestResponse response) {
            responses.Add(response);
        }
    }
}
