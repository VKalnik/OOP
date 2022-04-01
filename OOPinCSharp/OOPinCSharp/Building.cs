using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPinCSharp
{
    public class Building
    {
        private static int Counter { get; set; }

        public int Number { get; set; }

        public int Height { get; set; }

        public int Floors { get; set; }

        public int Porches { get; set; }

        public int Apartments { get; set; }


        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Building"/>.
        /// </summary>
        public Building()
        {
            Counter++;
            Number = Counter;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Building"/> с указанными параметрами.
        /// </summary>
        /// <param name="heightPerFloor">Высота этажа</param>
        /// <param name="floors">Количество этажей здания</param>
        /// <param name="porches">Количество подъездов здания</param>
        /// <param name="apartmentsInPorchPerFloor">Количество квартир на этаже в одном подъезде здания</param>
        public Building(int heightPerFloor, int floors, int porches, int apartmentsInPorchPerFloor)
        {
            Counter++;
            Number = Counter;
            Height = heightPerFloor * floors;
            Floors = floors;
            Porches = porches;
            Apartments = apartmentsInPorchPerFloor * floors * porches;
        }

        public int Q()
        {
            return Height;
        }

        public int GetHeightFloor() => Height/Floors;

        public int GetApartmentsInPorches() => Apartments/Porches;
        public int GetApartmentsOnFloorInBuilding() => Apartments/Floors;
        public int GetApartmentsInPorchPerFloor() => GetApartmentsInPorches()/Floors;

        public override string ToString() => $"Здание №: {Number}, высота: {Height}, этажей: {Floors}, подъездов: {Porches}, квартир: {Apartments}";
    }
}
