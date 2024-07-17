import Dashboard from '@/pages/dashboard/Dashboard'
import { createBrowserRouter } from 'react-router-dom'
import AppLayout from './AppLayout'

const browserRouter = createBrowserRouter([
	{
		path: '/',
		element: <AppLayout />,
		children: [
			{
				path: '/',
				element: <Dashboard />,
			},
		],
	},
])

export default browserRouter
