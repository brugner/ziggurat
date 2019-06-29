using Corlib.Core.Domain;
using System;
using System.Collections.Generic;

namespace Corlib.Core.Repositories
{
	internal interface IMemberRepository : IRepository<Member>
	{
		IEnumerable<Member> GetAll(int[] ids);
		void Delete(Member member);
		string GetFullName(int id);
		IEnumerable<Member> GetBirthdays();
		string GetLastCheckin(int id);
		int GetTotalCheckins(int id);
		string GetFavoriteTraining(int id);
		string GetFavoriteProduct(int id);
		IList<Tuple<DateTime, int>> GetCountGroupedByJoiningDate();
		IList<Tuple<string, int>> GetCountGroupedByGender();
	}
}
