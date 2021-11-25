﻿using System.Collections.Generic;

namespace weave2trial
{
    public class ProtocolInstanceIdentity
    {
        private readonly string _id;

        public ProtocolInstanceIdentity() {
            _id = _names.Dequeue();
        }

        public override string ToString() => _id;
        public override int GetHashCode() => _id.GetHashCode();
        public override bool Equals(object? obj) => obj is ProtocolInstanceIdentity niobj && _id.Equals(niobj._id);
        public static bool operator ==(ProtocolInstanceIdentity? a, ProtocolInstanceIdentity? b) => a is null ? b is null : b is not null && a._id.Equals(b._id);
        public static bool operator !=(ProtocolInstanceIdentity? a, ProtocolInstanceIdentity? b) => !(a == b);

        private static Queue<string> _names = new(new[] {
            "Tokyo", "Delhi", "Seoul", "Shanghai", "São Paulo", "Mexico City", "Cairo", "Mumbai", "Beijing", "Dhaka",
            "Osaka", "New York", "Karachi", "Buenos Aires", "Chongqing", "Istanbul", "Kolkata", "Manila", "Lagos",
            "Rio de Janeiro", "Tianjin", "Kinshasa", "Guangzhou", "Los Angeles", "Moscow", "Shenzhen", "Lahore",
            "Bangalore", "Paris", "Bogotá", "Jakarta", "Chennai", "Lima", "Bangkok", "Nagoya", "Hyderabad", "London",
            "Tehran", "Chicago", "Chengdu", "Nanjing", "Wuhan", "Ho Chi Minh City", "Luanda", "Ahmedabad",
            "Kuala Lumpur", "Xi'an", "Hong Kong", "Dongguan", "Hangzhou", "Foshan", "Shenyang", "Riyadh", "Baghdad",
            "Santiago", "Surat", "Madrid", "Suzhou", "Pune", "Harbin", "Houston", "Dallas", "Toronto", "Dar es Salaam",
            "Miami", "Belo Horizonte", "Singapore", "Philadelphia", "Atlanta", "Fukuoka", "Khartoum", "Barcelona",
            "Johannesburg", "Saint Petersburg", "Qingdao", "Dalian", "Washington", "Yangon", "Alexandria", "Jinan",
            "Guadalajara"
        });
    }
}
