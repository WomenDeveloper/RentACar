using System.Linq;
using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concreate;
using System.Linq.Expressions;
using System;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
             _colors = new List<Color>
            {
                new Color(){ColorId=1,ColorName="Red"},
                new Color(){ColorId=2,ColorName="Gray"},
                new Color(){ColorId=3,ColorName="Blue"},

            };
        }
        public void Add(Color color)
        {
            _colors.Add(color);
        }

        public void Delete(Color color)
        {
            Color deleteToColor = _colors.SingleOrDefault(c => c.ColorId == color.ColorId);
            _colors.Remove(deleteToColor);
        }

        public List<Color> GetAll()
        {
            return _colors;
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Color GetById(int id)
        {
            return _colors.SingleOrDefault(c=>c.ColorId==id);
        }

        public Color GetById(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Color color)
        {
            Color updateToColor = _colors.SingleOrDefault(c => c.ColorId == color.ColorId);
            updateToColor.ColorName = color.ColorName;
        }
    }
}

