using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using DemoListView.Models;

namespace DemoListView.Adapters
{
    public class PersonListAdapter : BaseAdapter<Person>
    {
        private readonly Activity _context;
        private readonly List<Person> _items;

        public PersonListAdapter(Activity context, List<Person> items) : base()
        {
            _context = context;
            _items = items;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _items[position];

            //La clase image helper se incluye en el código fuente
            var imageBitmap = ImageHelper.GetImageBitMapFromUrl("http://lorempixel.com/200/200/people/");

            if (convertView == null)
            {
                convertView = _context.LayoutInflater
                    .Inflate(Resource.Layout.PersonItemLayout, null);
            }

            convertView.FindViewById<TextView>(Resource.Id.personNameTextView).Text =
                item.Name;

            convertView.FindViewById<TextView>(Resource.Id.personLastNameTextView).Text =
                item.LastName;

            convertView.FindViewById<ImageView>(Resource.Id.personImageView)
                .SetImageBitmap(imageBitmap);

            return convertView;
        }

        public override int Count => _items.Count;

        public override Person this[int position]
            => _items[position];
    }
}