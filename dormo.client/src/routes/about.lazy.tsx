import { createLazyFileRoute  } from '@tanstack/react-router'

export const Route = createLazyFileRoute('/about')({
    component: AboutLazy,
})

function AboutLazy() {
    return <div className="p-2">Hello from About!</div>
}