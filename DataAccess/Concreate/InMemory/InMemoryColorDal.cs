using System.Linq;
using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concreate;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
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

        public void Update(Color color)
        {
            Color updateToColor = _colors.SingleOrDefault(c => c.ColorId == color.ColorId);
            updateToColor.ColorName = color.ColorName;
        }
    }
}

