import SideMenu from './SideMenu'
import { Outlet } from 'react-router-dom'

const AppLayout = () => {
	return (
		<div className='flex w-screen h-screen'>
			<SideMenu />
			<div className='flex-grow overflow-auto p-6 w-full'>
				<Outlet />
			</div>
		</div>
	)
}

export default AppLayout
