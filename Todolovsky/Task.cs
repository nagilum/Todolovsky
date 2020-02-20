using System;
using System.Linq;

namespace Todolovsky {
    public class Task {
        #region Properties

        public string Id { get; set; }

        public DateTimeOffset Created { get; set; }

        public DateTimeOffset Updated { get; set; }

        public DateTimeOffset? Deleted { get; set; }
        
        public DateTimeOffset? Due { get; set; }

        public DateTimeOffset? Completed { get; set; }

        public string Text { get; set; }

        #endregion

        #region Helper functions

        /// <summary>
        /// Return a new task object with a correct properties.
        /// </summary>
        /// <param name="text">Task text.</param>
        /// <returns>Task.</returns>
        public static Task NewTask(string text) {
            var id = Guid.NewGuid().ToString();

            while (true) {
                if (TaskHandler.Tasks == null) {
                    break;
                }

                if (TaskHandler.Tasks.All(n => n.Id != id)) {
                    break;
                }

                id = Guid.NewGuid().ToString();
            }

            return new Task {
                Id = id,
                Created = DateTimeOffset.Now,
                Updated = DateTimeOffset.Now,
                Text = text
            };
        }

        #endregion
    }
}