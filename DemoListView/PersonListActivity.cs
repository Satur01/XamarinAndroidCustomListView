using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;
using DemoListView.Adapters;
using DemoListView.Models;

namespace DemoListView
{
    [Activity(Label = "Person Activity", MainLauncher = true)]
    public class PersonListActivity : Activity
    {
        private ListView _personListView;
        private List<Person> _persons;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PersonListView);
            _personListView = FindViewById<ListView>(Resource.Id.PersonListViewControl);
            _persons = GetPersons();
            _personListView.Adapter = new PersonListAdapter(this, _persons);

        }

        private List<Person> GetPersons()
        {
            var result = new List<Person>()
            {
                new Person()
                {
                    Name = "Saturnino",
                    LastName = "Pimentel"
                },
                new Person()
                {
                    Name = "Luis",
                    LastName = "Perez"
                },
                new Person()
                {
                    Name = "María",
                    LastName = "Ruíz"
                }
            };
            return result;
        }
    }
}