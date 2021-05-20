using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAnnounce
{
    public class Post
    {
        // Attributes
        private string _title;
        private string _when;
        private string _where;
        private string _what;
        private string _emoji;

        // Constructor with all attributes
        public Post(string title, string when, string where, string what, string emoji)
        {
            _title = title;
            _when = when;
            _where = where;
            _what = what;
            _emoji = emoji;
        }

        // Methods

        public string GenerateTwt()
        {
            return $"**{_emoji} {_title} {_emoji}**\n\n📆When: {_when}\n❓Where: {_where}\n📍What: {_what}\n\n@everyone";
        }

        // GETTERS AND SETTERS
        /// Title Getter
        public string Title
        {
            get { return _title; }
        }
        /// When Getter
        public string When
        {
            get { return _when; }
        }
        /// Where Getter
        public string Where
        {
            get { return _where; }
        }
        /// What Getter
        public string What
        {
            get { return _what; }
        }
        /// Emoji Getter
        public string Emoji
        {
            get { return _emoji; }
        }

    }
}
