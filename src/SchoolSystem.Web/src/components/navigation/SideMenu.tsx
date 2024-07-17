import { Link } from 'lucide-react'

const SideMenu = () => {
	return (
		<div className='bg-gray-800 w-64 h-screen'>
			<div className='flex flex-col items-center justify-center h-16 bg-gray-900 text-white'>
				<h1 className='text-lg font-bold'>School System</h1>
			</div>
			<div className='flex flex-col items-center justify-center h-16 bg-gray-900 text-white'>
				<Link to='/students' className='hover:bg-gray-700 hover:text-white p-2'>
					Students
				</Link>
				<Link to='/courses' className='hover:bg-gray-700 hover:text-white p-2'>
					Courses
				</Link>
				<Link to='/teachers' className='hover:bg-gray-700 hover:text-white p-2'>
					Teachers
				</Link>
			</div>
		</div>
	)
}

export default SideMenu
